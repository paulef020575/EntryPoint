#region Copyright (C) 2003-2015 Stimulsoft
/*
{*******************************************************************}
{																	}
{	Stimulsoft Reports       										}
{																	}
{	Copyright (C) 2003-2015 Stimulsoft     							}
{	ALL RIGHTS RESERVED												}
{																	}
{	The entire contents of this file is protected by U.S. and		}
{	International Copyright Laws. Unauthorized reproduction,		}
{	reverse-engineering, and distribution of all or any portion of	}
{	the code contained in this file is strictly prohibited and may	}
{	result in severe civil and criminal penalties and will be		}
{	prosecuted to the maximum extent possible under the law.		}
{																	}
{	RESTRICTIONS													}
{																	}
{	THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES			}
{	ARE CONFIDENTIAL AND PROPRIETARY								}
{	TRADE SECRETS OF Stimulsoft										}
{																	}
{	CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON		}
{	ADDITIONAL RESTRICTIONS.										}
{																	}
{*******************************************************************}
*/
#endregion Copyright (C) 2003-2015 Stimulsoft

using System;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Dictionary.Design;
using Stimulsoft.Base;
using Stimulsoft.Base.Localization;

namespace Stimulsoft.Report.Dictionary
{
	public class StiFirebirdAdapterService : StiSqlAdapterService
	{
		#region StiService override
		public override  string ServiceName
		{
			get
			{
				return StiLocalization.Get("Adapters", "AdapterFirebirdConnection");
			}
		}
		#endregion

		#region StiDataAdapterService override 
		public override StiDataColumnsCollection GetColumnsFromData(StiData data, StiDataSource dataSource)
		{
			StiDataColumnsCollection dataColumns = new StiDataColumnsCollection();
			StiSqlSource sqlSource = dataSource as StiSqlSource;

			try
			{
				if (sqlSource.SqlCommand != null && sqlSource.SqlCommand.Length > 0)
				{
					if (data.Data is FbConnection)
					{
						FbConnection connection = data.Data as FbConnection;
						OpenConnection(connection, data, dataSource.Dictionary);
						using (FbDataAdapter dataAdapter = new FbDataAdapter(sqlSource.SqlCommand, connection))
						{
							DataTable dataTable = new DataTable();
							dataTable.TableName = sqlSource.Name;

							dataAdapter.SelectCommand.Prepare();							
														
							dataAdapter.FillSchema(dataTable, SchemaType.Source);
						
							foreach (DataColumn column in dataTable.Columns)
							{
								dataColumns.Add(new StiDataColumn(column.ColumnName, column.Caption, column.DataType));
							}
							
							dataTable.Dispose();
						}
						CloseConnection(data, connection);
					}
				}
			}
			catch (Exception e)
			{
				StiLogService.Write(this.GetType(), e);
			}
			
			return dataColumns;
		}

		public override void SetDataSourceNames(StiData data, StiDataSource dataSource)
		{
			base.SetDataSourceNames(data, dataSource);

			dataSource.Name = "FirebirdSource";
			dataSource.Alias = "FirebirdSource";
		}

		public override Type GetDataSourceType()
		{
			return typeof(StiFirebirdSource);
		}

		public override Type[] GetDataTypes()
		{
			return new Type[]{typeof(FbConnection)};
		}

		public override void ConnectDataSourceToData(StiDictionary dictionary, StiDataSource dataSource, bool loadData)
		{
			dataSource.Disconnect();
			if (!loadData)
			{
				dataSource.DataTable = new DataTable();
				return;
			}
			
			StiSqlSource sqlSource = dataSource as StiSqlSource;

			foreach (StiData data in dataSource.Dictionary.DataStore)
			{
				if (data.Name == sqlSource.NameInSource)
				{
					try
					{
						if (data.Data is FbConnection)
						{
							FbConnection connection = data.ViewData as FbConnection;	
							OpenConnection(connection, data, dataSource.Dictionary);
							
							sqlSource.DataAdapter = new FbDataAdapter(sqlSource.SqlCommand, connection);
														
							foreach (StiDataParameter parameter in sqlSource.Parameters)
							{
								((FbDataAdapter)sqlSource.DataAdapter).SelectCommand.Parameters.Add(
									parameter.Name, (FbDbType)parameter.Type, parameter.Size);
							}

							DataTable dataTable = new DataTable();
							dataTable.TableName = sqlSource.Name;
							dataSource.DataTable = dataTable;

							sqlSource.DataAdapter.SelectCommand.CommandTimeout = sqlSource.CommandTimeout;								
							if (loadData && sqlSource.Parameters.Count > 0)
							{
								sqlSource.DataAdapter.SelectCommand.Prepare();
								sqlSource.UpdateParameters();
							}
							else
							{														
								if (loadData)
								{
									((FbDataAdapter)sqlSource.DataAdapter).Fill(dataTable);
									sqlSource.CheckColumnsIndexs();
								}
								else ((FbDataAdapter)sqlSource.DataAdapter).FillSchema(dataTable, SchemaType.Source);
							}						
							
							break;
						}
					}
					catch (Exception e)
					{
						StiLogService.Write(this.GetType(), e);
						if (!StiOptions.Engine.HideExceptions)throw;
					}
				}
			}
		}
		#endregion

		#region StiSqlAdapterService override
		public override void CreateConnectionInDataStore(StiDictionary dictionary, StiSqlDatabase database)
		{
			try
			{
				#region remove all old data from datastore
				int index = 0;
				foreach (StiData oldData in dictionary.DataStore)
				{
					if (oldData.Name == database.Name)
					{
						dictionary.DataStore.RemoveAt(index);
						break;
					}
					index++;
				}
				#endregion

				FbConnection sqlConnection = new FbConnection(database.ConnectionString);
				
				StiData data = new StiData(database.Name, sqlConnection);
				data.IsReportData = true;
				dictionary.DataStore.Add(data);
				
			}
			catch (Exception e)
			{
                if (!StiOptions.Engine.HideMessages) Stimulsoft.Base.StiExceptionProvider.Show(e);
			}
		}


        public override string TestConnection(string connectionString)
		{
			try
			{				
				using (FbConnection sqlConnection = new FbConnection(connectionString))
				{
					sqlConnection.Open();
					sqlConnection.Close();
                    return StiLocalization.Get("DesignerFx", "ConnectionSuccessfull");
                }
            }
            catch (Exception e)
            {
                return StiLocalization.Get("DesignerFx", "ConnectionError") + ": " + e.Message;
            }	    
		}
		#endregion
	}
}

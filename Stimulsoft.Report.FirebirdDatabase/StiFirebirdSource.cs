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
using System.Collections;
using System.Data;
using System.ComponentModel;
using Stimulsoft.Base;
using Stimulsoft.Base.Localization;
using Stimulsoft.Base.Serializing;
using Stimulsoft.Report.Dictionary.Design;
using Stimulsoft.Report.Events;
using FirebirdSql.Data.FirebirdClient;

namespace Stimulsoft.Report.Dictionary
{
	[TypeConverter(typeof(StiSqlSourceConverter))]
	public class StiFirebirdSource : StiSqlSource
	{
		#region DataAdapter
		protected override Type ConvertDbTypeToTypeInternal(int sqlType)
		{
			FbDbType dbType = (FbDbType)sqlType;
			switch (dbType)
			{
				case FbDbType.BigInt:
				case FbDbType.Integer:
				case FbDbType.SmallInt:
					return typeof(Int64);

				case FbDbType.Decimal:
				case FbDbType.Numeric:
					return typeof(decimal);

				case FbDbType.Double:
				case FbDbType.Float:
					return typeof(double);
				
				case FbDbType.Date:
				case FbDbType.TimeStamp:
					return typeof(DateTime);

				default:
					return typeof(string);
			}
		}

		public override Type GetParameterTypesEnum()
		{
			return typeof(FbDbType);
		}

		public override StiDataParameter AddParameter()
		{
			StiDataParameter parameter = new StiDataParameter(
				StiLocalization.Get("PropertyMain", "Parameter"), string.Empty, (int)FbDbType.Text, 0);
			Parameters.Add(parameter);
			return parameter;
		}

		public virtual StiDataParameter AddParameter(string name, string expression, FbDbType type, int size)
		{
			StiDataParameter parameter = AddParameter();
			parameter.Name = name;
			parameter.Expression = expression;
			parameter.Type = (int)type;
			parameter.Size = size;

			return parameter;
		}

		public override void UpdateParameters()
		{
			if (this.DataTable != null)
			{
				InvokeConnecting();
				foreach (StiDataParameter parameter in Parameters)
				{
					((FbDataAdapter)DataAdapter).SelectCommand.Parameters[parameter.Name].Value = parameter.GetParameterValue();
				}
				DataTable dataTable = this.DataTable;
				dataTable.Rows.Clear();

                ((FbDataAdapter)DataAdapter).SelectCommand.CommandTimeout = this.CommandTimeout;
				((FbDataAdapter)DataAdapter).Fill(dataTable);
			
				CheckColumnsIndexs();
			}			
		}

		protected override string DataAdapterType
		{
			get
			{
				return "Stimulsoft.Report.Dictionary.StiFirebirdAdapterService";
			}
		}
		#endregion

		#region this
		public StiFirebirdSource() : this("", "", "")
		{
		}

		public StiFirebirdSource(string nameInSource, string name) : this(nameInSource, name, name)
		{
		}

		public StiFirebirdSource(string nameInSource, string name, string alias) : this(nameInSource, name, alias, string.Empty)
		{

		}

		public StiFirebirdSource(string nameInSource, string name, string alias, string sqlCommand) : 
			base(nameInSource, name, alias, sqlCommand)			
		{
		}

		public StiFirebirdSource(string nameInSource, string name, string alias, string sqlCommand, 
			bool connectOnStart) : 
		base(nameInSource, name, alias, sqlCommand, connectOnStart)
		{
		}

		public StiFirebirdSource(string nameInSource, string name, string alias, string sqlCommand, 
			bool connectOnStart, bool reconnectOnEachRow) : 
			base(nameInSource, name, alias, sqlCommand, connectOnStart, reconnectOnEachRow)
		{
		}

		public StiFirebirdSource(string nameInSource, string name, string alias, string sqlCommand, 
			bool connectOnStart, bool reconnectOnEachRow, int commandTimeout) : 
			base(nameInSource, name, alias, sqlCommand, connectOnStart, reconnectOnEachRow, commandTimeout)
		{
		}
		#endregion
	}
}


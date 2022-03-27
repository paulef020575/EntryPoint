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
using System.Windows.Forms;
using System.ComponentModel;
using Stimulsoft.Base.Localization;
using Stimulsoft.Base.Serializing;
using Stimulsoft.Report.Dictionary;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Collections;
using Stimulsoft.Report.Dictionary.Design;

namespace Stimulsoft.Report.Dictionary
{
    [TypeConverter(typeof(StiSqlDatabaseConverter))]
    public class StiFirebirdDatabase : StiSqlDatabase
    {
        #region StiService override
        public override string ServiceName
        {
            get
            {
                return StiLocalization.Get("Database", "DatabaseFirebird");
            }
        }
        #endregion

        #region DataAdapter override
        protected override string DataAdapterType
        {
            get
            {
                return "Stimulsoft.Report.Dictionary.StiFirebirdAdapterService";
            }
        }
        #endregion

        public override DialogResult Edit(bool newDatabase)
        {
            using (StiSqlDatabaseEditForm form = new StiSqlDatabaseEditForm(this))
            {
                if (newDatabase) form.Text = StiLocalization.Get("FormDatabaseEdit", "FirebirdNew");
                else form.Text = StiLocalization.Get("FormDatabaseEdit", "FirebirdEdit");

                form.tbName.Text = this.Name;
                form.tbAlias.Text = this.Alias;
                form.tbConnectionString.Text = this.ConnectionString;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.Name = form.tbName.Text;
                    this.Alias = form.tbAlias.Text;
                    this.ConnectionString = form.tbConnectionString.Text;
                }
                return form.DialogResult;
            }
        }

        public override void ApplyDatabaseInformation(StiDatabaseInformation information, StiReport report, StiDatabaseInformation informationAll)
        {
            #region Tables

            foreach (DataTable dataTable in information.Tables)
            {
                StiFirebirdSource source = new StiFirebirdSource(this.Name,
                    StiNameCreation.CreateName(report, dataTable.TableName, false, false, true));
                string table = dataTable.TableName;
                if (table.Trim().Contains(" ")) table = string.Format("[{0}]", table);
                source.SqlCommand = "select * from " + table;

                foreach (DataColumn dataColumn in dataTable.Columns)
                {
                    StiDataColumn column = new StiDataColumn(dataColumn.ColumnName, dataColumn.DataType);
                    source.Columns.Add(column);
                }
                report.Dictionary.DataSources.Add(source);
            }
            #endregion
        }

        public override void ApplyDatabaseInformation(StiDatabaseInformation information, StiReport report)
        {
            ApplyDatabaseInformation(information, report, null);
        }

        /// <summary>
        /// Returns full database information.
        /// </summary>
        public override StiDatabaseInformation GetDatabaseInformation()
        {
            StiDatabaseInformation information = new StiDatabaseInformation();
            try
            {
                using (FbConnection connection = new FbConnection(this.ConnectionString))
                {
                    connection.Open();

                    #region Tables and Columns
                    Hashtable tableHash = new Hashtable();
                    DataTable tables = connection.GetSchema("Tables", new string[] { null, null, null, "TABLE" });

                    foreach (DataRow row in tables.Rows)
                    {
                        string tableName = row["TABLE_NAME"] as string;
                        DataTable table = new DataTable(tableName);

                        DataTable columns = connection.GetSchema("Columns", new string[] { null, null, tableName });
                        foreach (DataRow rowColumn in columns.Rows)
                        {
                            string columnFbType = (string)rowColumn["COLUMN_DATA_TYPE"];
                            Type columnType = ConvertDbTypeToTypeInternal(columnFbType);
                            table.Columns.Add(rowColumn["COLUMN_NAME"] as string, columnType);
                        }
                        tableHash[tableName] = table;
                        information.Tables.Add(table);
                    }
                    #endregion

                    connection.Close();
                }


                return information;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        private Type ConvertDbTypeToTypeInternal(string dbType)
        {
            if (dbType == "date" || dbType.Contains("time"))
                return typeof(DateTime);

            switch (dbType)
            {
                case "smallint":
                case "integer":
                case "bigint":
                    return typeof(int);

                case "float":
                case "double precision":
                case "numeric":
                case "decimal":
                    return typeof(decimal);

                case "blob":
                    return typeof(byte[]);

                default:
                    return typeof(string);
            }
        }

        /// <summary>
        /// Creates a new object of the type StiFirebirdDatabase.
        /// </summary>
        public StiFirebirdDatabase()
            : this(string.Empty, string.Empty)
        {
        }


        /// <summary>
        /// Creates a new object of the type StiFirebirdDatabase.
        /// </summary>
        public StiFirebirdDatabase(string name, string connectionString)
            : base(name, connectionString)
        {
        }


        /// <summary>
        /// Creates a new object of the type StiFirebirdDatabase.
        /// </summary>
        public StiFirebirdDatabase(string name, string alias, string connectionString)
            : base(name, alias, connectionString)
        {
        }

        /// <summary>
        /// Creates a new object of the type StiFirebirdDatabase.
        /// </summary>
        public StiFirebirdDatabase(string name, string alias, string connectionString, bool promptUserNameAndpassword)
            : base(name, alias, connectionString, promptUserNameAndpassword)
        {
        }

    }

}

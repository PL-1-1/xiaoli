using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace YH.Core.Model.Models
{
    ///<summary>
    ///
    ///</summary>{SugarTable}
    public partial class student
    {
           public student(){


           }
           /// <summary>
           /// Desc:
           /// Default:{DefaultValue}
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,ColumnName="ID",Length=11,ColumnDescription="")]
           public int ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:{DefaultValue}
           /// Nullable:True
           /// </summary>           
           [SugarColumn(ColumnName="UserName",IsNullable=true,Length=255,ColumnDataType="varchar",ColumnDescription="")]
           public string UserName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:{DefaultValue}
           /// Nullable:True
           /// </summary>           
           [SugarColumn(ColumnName="UserPwd",IsNullable=true,Length=255,ColumnDataType="varchar",ColumnDescription="")]
           public string UserPwd {get;set;}

           /// <summary>
           /// Desc:
           /// Default:{DefaultValue}
           /// Nullable:True
           /// </summary>           
           [SugarColumn(ColumnName="UserAge",IsNullable=true,Length=255,ColumnDataType="varchar",ColumnDescription="")]
           public string UserAge {get;set;}

           /// <summary>
           /// Desc:
           /// Default:{DefaultValue}
           /// Nullable:True
           /// </summary>           
           [SugarColumn(ColumnName="UserAddress",IsNullable=true,Length=255,ColumnDataType="varchar",ColumnDescription="")]
           public string UserAddress {get;set;}

           /// <summary>
           /// Desc:
           /// Default:{DefaultValue}
           /// Nullable:True
           /// </summary>           
           [SugarColumn(ColumnName="UserPhone",IsNullable=true,Length=255,ColumnDataType="varchar",ColumnDescription="")]
           public string UserPhone {get;set;}

    }
}

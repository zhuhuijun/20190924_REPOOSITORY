﻿using Hulu.Util.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
/************************************************************
* 命名空间: Hulu.Data.Repository
*
* 功 能： N/A
* 接 口： IRepository
*
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2019/10/28 15:50:35 Hulu 初版
*
*************************************************************/
namespace Hulu.Data.Repository
{
    /// <summary>
    /// 定义仓储模型中的数据标准操作接口
    /// </summary>
    public interface IRepository
    {
        IRepository BeginTrans();
        void Commit();
        void Rollback();

        int ExecuteBySql(string strSql);
        int ExecuteBySql(string strSql, params DbParameter[] dbParameter);
        int ExecuteByProc(string procName);
        int ExecuteByProc(string procName, params DbParameter[] dbParameter);

        int Insert<T>(T entity) where T : class;
        int Insert<T>(List<T> entity) where T : class;
        int Delete<T>() where T : class;
        int Delete<T>(T entity) where T : class;
        int Delete<T>(List<T> entity) where T : class;
        int Delete<T>(Expression<Func<T, bool>> condition) where T : class, new();
        int Delete<T>(object keyValue) where T : class;
        int Delete<T>(object[] keyValue) where T : class;
        int Delete<T>(object propertyValue, string propertyName) where T : class;
        int Update<T>(T entity) where T : class;
        int Update<T>(List<T> entity) where T : class;
        int Update<T>(Expression<Func<T, bool>> condition) where T : class, new();

        T FindEntity<T>(object keyValue) where T : class;
        T FindEntity<T>(Expression<Func<T, bool>> condition) where T : class, new();
        IQueryable<T> IQueryable<T>() where T : class, new();
        IQueryable<T> IQueryable<T>(Expression<Func<T, bool>> condition) where T : class, new();
        IEnumerable<T> FindList<T>(string strSql) where T : class;
        IEnumerable<T> FindList<T>(string strSql, DbParameter[] dbParameter) where T : class;
        IEnumerable<T> FindList<T>(Pagination pagination) where T : class, new();
        IEnumerable<T> FindList<T>(Expression<Func<T, bool>> condition, Pagination pagination) where T : class, new();
        IEnumerable<T> FindList<T>(Expression<Func<T, bool>> condition) where T : class, new();
        IEnumerable<T> FindList<T>(string strSql, Pagination pagination) where T : class;
        IEnumerable<T> FindList<T>(string strSql, DbParameter[] dbParameter, Pagination pagination) where T : class;

        DataTable FindTable(string strSql);
        DataTable FindTable(string strSql, DbParameter[] dbParameter);
        DataTable FindTable(string strSql, Pagination pagination);
        DataTable FindTable(string strSql, DbParameter[] dbParameter, Pagination pagination);
        object FindObject(string strSql);
        object FindObject(string strSql, DbParameter[] dbParameter);
    }
}

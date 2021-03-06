﻿using AlonsoAdmin.Common.ResponseEntity;
using AlonsoAdmin.Services.System.Request;
using System.Threading.Tasks;

namespace AlonsoAdmin.Services.System.Interface
{
    public interface ISysPermissionService : IBaseService<PermissionFilterRequest, PermissionAddRequest, PermissionEditRequest>
    {

        #region 特殊接口 在此定义

        /// <summary>
        /// 为指定权限岗分配权限
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        Task<IResponseEntity> PermissionAssignPowerAsync(PermissionAssignPowerRequest req);

        /// <summary>
        /// 取指定权限岗下的数据组ID集合
        /// </summary>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        Task<IResponseEntity> GetGroupIdsByPermissionIdAsync(string permissionId);

        /// <summary>
        /// 取指定权限岗下的角色ID集合
        /// </summary>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        Task<IResponseEntity> GetRoleIdsByPermissionIdAsync(string permissionId);

        #endregion

    }
}

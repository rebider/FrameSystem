﻿using System;

namespace Frame.Models.SysModels.Staff
{
    public class StaffUpdateRequestModel
    {
        /// <summary>
        /// 部门编号
        /// </summary>
        public int DeptId { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birth { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        public string Add { get; set; }

        /// <summary>
        /// 加入时间
        /// </summary>
        public DateTime InTime { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool State { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public string Oper { get; set; }
    }
}

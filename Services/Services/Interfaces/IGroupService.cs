﻿using Services.DTOs.Admin.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interfaces
{
    public  interface IGroupService
    {
        Task<IEnumerable<GroupDto>> GetAllAsync();

        Task CreateAsync(GroupCreateDto model);

        Task<GroupDto> GetByIdAsync(int? id);

        Task DeleteAsync(int? id);

        Task EditAsync(int? id, GroupEditDto model);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Poker.Shared;
using Poker.Shared.Models;

namespace Poker.Client.Services
{
    public interface ITableService
    {
        Task<CreateTableResult> Create(CreateTableModel model);

        Task<GetTablesResult> GetList();

        Task<PokerTable> GetById(int id);

        Task<DeleteTableResult> Delete(int id);
    }
}

﻿using XuongMayNhom8.Repositories.Models;

namespace XuongMayNhom8.Repositories.Interfaces
{
	public interface ITaskRepository
	{
		Task<IEnumerable<Congviec>> GetAll();
		Task<PagedResult<Congviec>> GetAll(int pageNumber, int pageSize);
		Task<Congviec?> GetById(int taskId);
		Task Add(Congviec task);
		Task Delete(int taskId);
		Task Update(Congviec task);
	}
}

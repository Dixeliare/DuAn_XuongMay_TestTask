﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuongMayNhom8.Repositories.Models
{
	public class PagedResult<T>
	{
		public IEnumerable<T> Items { get; set; } = [];
		public int TotalCount { get; set; }
		public int PageNumber { get; set; }
		public int PageSize { get; set; }
	}
}

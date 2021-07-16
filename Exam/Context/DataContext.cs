using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Exam.Models;

namespace Exam.Context
{
	public class DataContext : DbContext
	{
		public DataContext() : base("Exam")
		{

		}

		public DbSet<ExamInfo> ExamInfos { get; set; }
	}
}
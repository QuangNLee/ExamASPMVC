using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{
	public class ExamInfo
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Vui lòng nhập môn thi")]
		public string Subject { get; set; }
		public TimeSpan StartTime { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public string ExamDate { get; set; }
		[Required(ErrorMessage = "Vui lòng nhập thời gian thi")]
		public int Duration { get; set; }
		[Required(ErrorMessage = "Vui lòng nhập phòng thi")]
		public string Classroom { get; set; }
		[Required(ErrorMessage = "Vui lòng nhập tên giáo viên trông thi")]
		public string Faculty { get; set; }
		[Required(ErrorMessage = "Vui lòng nhập trạng thái")]
		public string Status { get; set; }
	}
}
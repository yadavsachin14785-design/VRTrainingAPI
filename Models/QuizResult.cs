using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VRTraining.Models
{
    [Table("quiz_results")]
    public class QuizResult
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("student_name")]
        public string? StudentName { get; set; }

        [Column("student_id")]
        public string? StudentID { get; set; }

        [Column("department")]
        public string? Department { get; set; }

        [Column("correct_answers")]
        public int CorrectAnswers { get; set; }

        [Column("wrong_answers")]
        public int WrongAnswers { get; set; }

        [Column("score")]
        public int Score { get; set; }

        [Column("total_time")]
        public string? TotalTime { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
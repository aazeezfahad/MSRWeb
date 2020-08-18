using System;
using System.ComponentModel.DataAnnotations;

namespace MSRWeb.Models
{
    public class Submission
    {
         public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DayOfSubmission { get; set; }

        public short ProjectId { get; set; }

        public byte DesignStageId { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public string PackageItems { get; set; }

        public string Revision { get; set; }

        public byte DocumentTypeId { get; set; }

        public string SubmissionId { get; set; }

        public byte ToWhom { get; set; }

        public string Folder { get; set; }
    }
}
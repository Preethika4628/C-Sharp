using System;
namespace SyncfusionAdmission
{
    public enum AdmissionStatus
    {
        Select, Admitted, Cancelled
    }
    public class AdmissionDetails
    {
        private static int s_admissionID = 1001;
        public string AdmissionID;
        public string StudentID;
        public string DepartmentID;
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus { get; set; }

        public AdmissionDetails(string studentName)
        {
            AdmissionStatus = AdmissionStatus.Select;
        }

        public AdmissionDetails(string s_studentID, string s_departmentID, DateTime admissionDate, AdmissionStatus admissionStatus)
        {
            s_admissionID++;
            AdmissionID = "AID" + s_admissionID;
            StudentID = s_studentID;
            DepartmentID = s_departmentID;
            AdmissionDate = admissionDate;
            AdmissionStatus = admissionStatus;
        }
    }


}
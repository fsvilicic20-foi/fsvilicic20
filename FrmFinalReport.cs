﻿private List<StudentReportView> GenerateStudentReport() {
    var allStudents = StudentRepository.GetStudents();
    var examReports = new List<StudentReportView>();
    foreach (var student in allStudents) {
        if (student.HasSignature() == true) {
            var examReport = new StudentReportView(student);
            examReports.Add(examReport);
        }
    }
    return examReports;
}
    var results = GenerateStudentReport();
    dgvResults.DataSource = results;
}
form.ShowDialog();
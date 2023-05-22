private List<StudentReportView> GenerateStudentReport() {
    var allStudents = StudentRepository.GetStudents();
    var examReports = new List<StudentReportView>();
    foreach (var student in allStudents) {
        if (student.HasSignature() == true) {
            var examReport = new StudentReportView(student);
            examReports.Add(examReport);
        }
    }
    return examReports;
}private void FrmFinalReport_Load(object sender, EventArgs e) {
    var results = GenerateStudentReport();
    dgvResults.DataSource = results;
}var form = new FrmFinalReport();
form.ShowDialog();
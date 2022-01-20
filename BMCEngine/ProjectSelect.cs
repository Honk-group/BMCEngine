namespace BMCEngine
{
    public partial class ProjectSelect : Form
    {
        public Form currentForm;
        public Form newProj;
        public ProjectSelect()
        {
            InitializeComponent();
        }

        private void InitializeVars()
        {
            currentForm = Form.ActiveForm;
            newProj = new NewProject();
        }

        private void ProjectSelect_Load(object sender, EventArgs e)
        {

        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            InitializeVars();
            OpenProjectSelect();
        }

        public void HideActiveForm()
        {
            currentForm.Hide();
        }

        public void OpenProjectSelect()
        {
            HideActiveForm();
            newProj.Show();
        }

        public Form GetCurrentForm()
        {
            return currentForm;
        }

        public Form GetNewProjForm()
        {
            return newProj;
        }
    }
}
namespace MasterOfArrays;
partial class MyForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
        SuspendLayout();
        // 
        // MyForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(782, 403);
        ForeColor = Color.DarkRed;
        MaximumSize = new Size(800, 450);
        MinimumSize = new Size(800, 450);
        Name = "MyForm";
        Text = "Master of Arrays";
        ResumeLayout(false);
    }
    private void AddingFunctionality()
    {
        _arrayEditor = new ArrayEditor();
        _dateBaseConnector = new DateBaseConnector();

        _accountCreatingWindow = new WindowAccountCreating(this);
        _enterWindow = new WindowEnter(this);

        _workDesk = new WindowWorkDesk(this);
        _windowRandomNambers = new WindowRandNum(_workDesk.MainPanel);
        _arrayEditWindow = new WindowArrayEdit(_workDesk.MainPanel);
        
        _saveArrayAsWindow = new WindowUserArrays(this);
        _openArrayWindow = new WindowUserArrays(this);
        _downloadArrayWindow = new WindowUserArrays(this);
        _deleteArrayWindow = new WindowUserArrays(this);
        _accEditorWindow = new WindowAccounEditor(this);

        _workDesk.Close();
        _accountCreatingWindow.Close();
        _saveArrayAsWindow.Close();
        _openArrayWindow.Close();
        _windowRandomNambers.Close();
        _arrayEditWindow.Close();
        _downloadArrayWindow.Close();
        _deleteArrayWindow.Close();
        _accountCreatingWindow.Close();

        _enterWindow.EnterButton_Click(Enter_Click);
        _enterWindow.ExitButton_Click(ExitFromProgramm_Click);
        _enterWindow.NewAccButton_Click(NewAcc_Click);

        _accountCreatingWindow.ExitButton_Click(ExitFromRegistration_Click);
        _accountCreatingWindow.FinishButton_Click(Finish_Click);

        _workDesk.newArrayToolStripMenuItem_Click(NewArray_Click);
        _workDesk.exitFromAccToolStripMenuItep_Click(ExitFromAcc_Click);
        _workDesk.editDataToolStripMenuItem_Click(EnterToEditAcc_Click);
        _workDesk.openToolStripMenuItem_Click(OpenArray_Click);
        _workDesk.saveArrayToolStripMenuItem_Click(SaveArray_Click);
        _workDesk.exitFromProgrammToolStripMenuItep_Click(ExitFromProgramm_Click);
        _workDesk.deleteArrayToolStripMenuItem_Click(DeleteArray_Click);
        _workDesk.showInfoToolStripMenuItep_Click(ShowInfo_Click);

        _arrayEditWindow.ClearArrayButton_Click(Clear_Click);
        _arrayEditWindow.FillRandomNumberButton_Click(OpenRandomNumberWindow_Click);
        _arrayEditWindow.ShowSourceArrayButton_Click(ShowSourceArray_Click);
        _arrayEditWindow.ShowSortedArrayButton_Click(ShowSortedArray_Click);
        _arrayEditWindow.DownloadArrayButton_Click(DownloadArray_Click);

        _windowRandomNambers.ExitButton_Click(ExitFormRandNumWindow_Click);
        _windowRandomNambers.EnterButton_Click(FillRandomNumber_Click);

        _openArrayWindow.CancelButton_Click(CancelOpenArray_Click);
        _openArrayWindow.EnterButton_Click(ChoiceArrayForOpen_Click);

        _saveArrayAsWindow.CancelButton_Click(CancelSaveArrayAs_Click);
        _saveArrayAsWindow.EnterButton_Click(ChoiceArrayForSave_Click);

        _downloadArrayWindow.EnterButton_Click(ChoiceArrayForDownload_Click);
        _downloadArrayWindow.CancelButton_Click(CancelDownloadArray_Click);

        _deleteArrayWindow.EnterButton_Click(ChoiceArrayForDelete_Click);
        _deleteArrayWindow.CancelButton_Click(CancelDeleteArray_Click);

        _accEditorWindow.BackButton_Click(BackToWorkDesk_Click);
        _accEditorWindow.DeleteAccButton_Click(DeleteAcc_Click);
        _accEditorWindow.ExitButton_Click(ExitFromAccount_Click);
        _accEditorWindow.ApplyButton_Click(Apply_Click);
    }

    private ArrayEditor _arrayEditor;
    private DateBaseConnector _dateBaseConnector;

    private WindowEnter _enterWindow;
    private WindowAccountCreating _accountCreatingWindow;

    private WindowWorkDesk _workDesk;
    private WindowRandNum _windowRandomNambers;
    private WindowArrayEdit _arrayEditWindow;
    private WindowAccounEditor _accEditorWindow;

    private WindowUserArrays _saveArrayAsWindow;
    private WindowUserArrays _openArrayWindow;
    private WindowUserArrays _downloadArrayWindow;
    private WindowUserArrays _deleteArrayWindow;
    #endregion


}
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
        arrayEditor = new ArrayEditor();
        dateBaseConnector = new DateBaseConnector();

        accCreatingWindow = new AccCreatingWindow(this);
        enterWindow = new EnterWindow(this);

        workDesk = new WorkDeskWindow(this);
        windowRandomNambers = new RandNumWindow(workDesk.MainPanel);
        arrayEditWindow = new ArrayEditWindow(workDesk.MainPanel);
        
        saveArrayAsWindow = new UserArraysWindow(this);
        openArrayWindow = new UserArraysWindow(this);
        downloadArrayWindow = new UserArraysWindow(this);
        deleteArrayWindow = new UserArraysWindow(this);
        accEditorWindow = new AccEditorWindow(this);

        workDesk.Close();
        accCreatingWindow.Close();
        saveArrayAsWindow.Close();
        openArrayWindow.Close();
        windowRandomNambers.Close();
        arrayEditWindow.Close();
        downloadArrayWindow.Close();
        deleteArrayWindow.Close();
        accCreatingWindow.Close();

        enterWindow.EnterButton_Click(Enter_Click);
        enterWindow.ExitButton_Click(ExitFromProgramm_Click);
        enterWindow.NewAccButton_Click(NewAcc_Click);

        accCreatingWindow.ExitButton_Click(ExitFromRegistration_Click);
        accCreatingWindow.FinishButton_Click(Finish_Click);

        workDesk.newArrayToolStripMenuItem_Click(NewArray_Click);
        workDesk.exitFromAccToolStripMenuItep_Click(ExitFromAcc_Click);
        workDesk.editDataToolStripMenuItem_Click(EnterToEditAcc_Click);
        workDesk.openToolStripMenuItem_Click(OpenArray_Click);
        workDesk.saveArrayAsToolStripMenuItem_Click(SaveArrayAs_Click);
        workDesk.saveArrayToolStripMenuItem_Click(SaveArray_Click);
        workDesk.exitFromProgrammToolStripMenuItep_Click(ExitFromProgramm_Click);
        workDesk.deleteArrayToolStripMenuItem_Click(DeleteArray_Click);

        arrayEditWindow.ClearArrayButton_Click(Clear_Click);
        arrayEditWindow.FillRandomNumberButton_Click(OpenRandomNumberWindow_Click);
        arrayEditWindow.ShowSourceArrayButton_Click(ShowSourceArray_Click);
        arrayEditWindow.ShowSortedArrayButton_Click(ShowSortedArray_Click);
        arrayEditWindow.DownloadArrayButton_Click(DownloadArray_Click);

        windowRandomNambers.ExitButton_Click(ExitFormRandNumWindow_Click);
        windowRandomNambers.EnterButton_Click(FillRandomNumber_Click);

        openArrayWindow.CancelButton_Click(CancelOpenArray_Click);
        openArrayWindow.EnterButton_Click(ChoiceArrayForOpen_Click);

        saveArrayAsWindow.CancelButton_Click(CancelSaveArrayAs_Click);
        saveArrayAsWindow.EnterButton_Click(ChoiceArrayForSave_Click);

        downloadArrayWindow.EnterButton_Click(ChoiceArrayForDownload_Click);
        downloadArrayWindow.CancelButton_Click(CancelDownloadArray_Click);

        deleteArrayWindow.EnterButton_Click(ChoiceArrayForDelete_Click);
        deleteArrayWindow.CancelButton_Click(CancelDeleteArray_Click);

        accEditorWindow.BackButton_Click(BackToWorkDesk_Click);
        accEditorWindow.DeleteAccButton_Click(DeleteAcc_Click);
        accEditorWindow.ExitButton_Click(ExitFromProgramm_Click);
        accEditorWindow.ApplyButton_Click(Apply_Click);
    }

    private ArrayEditor arrayEditor;
    private DateBaseConnector dateBaseConnector;

    private EnterWindow enterWindow;
    private AccCreatingWindow accCreatingWindow;

    private WorkDeskWindow workDesk;
    private RandNumWindow windowRandomNambers;
    private ArrayEditWindow arrayEditWindow;
    private AccEditorWindow accEditorWindow;

    private UserArraysWindow saveArrayAsWindow;
    private UserArraysWindow openArrayWindow;
    private UserArraysWindow downloadArrayWindow;
    private UserArraysWindow deleteArrayWindow;
    #endregion


}
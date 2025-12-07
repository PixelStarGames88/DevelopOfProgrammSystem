using System.Windows.Forms;

namespace MasterOfArrays;

public partial class MyForm : Form
{
    public MyForm()
    {
        InitializeComponent();
        AddingFunctionality();
    }
    private void Enter_Click(object o, EventArgs e)
    {
        if(!dateBaseConnector.SignIsWellDone(enterWindow.UserNameBox.Text, enterWindow.passwordBox.Text))
        {
            return;
        }

        workDesk.ChangeName(enterWindow.UserNameBox.Text);
        enterWindow.Close();
        workDesk.Open();
        arrayEditWindow.Open();
        accEditorWindow.FillTextBoxes(dateBaseConnector.CurrentFirstName, dateBaseConnector.CurrentLastName,
                                  dateBaseConnector.CurrentUserLogin, dateBaseConnector.CurrentPassword);
    }
    private void ExitFromProgramm_Click(object o, EventArgs e)
    {
        Application.Exit();
    }
    private void NewAcc_Click(object o, EventArgs e)
    {
        enterWindow.Close();
        accCreatingWindow.Open();
    }

    private void ExitFromRegistration_Click(object o, EventArgs e)
    {
        accCreatingWindow.Close();
        enterWindow.Open();
    }
    private void Finish_Click(object o, EventArgs e)
    {
        if (dateBaseConnector.AddUser(accCreatingWindow.LoginNameBox.Text,
                                                      accCreatingWindow.PasswordBox.Text,
                                                      accCreatingWindow.FirstNameBox.Text,
                                                      accCreatingWindow.LastNameBox.Text)
            && accCreatingWindow.PasswordBox.Text == accCreatingWindow.RepeatPasswordBox.Text)
        {
            workDesk.ChangeName(accCreatingWindow.LoginNameBox.Text);
            accCreatingWindow.Close();
            workDesk.Open();
            arrayEditWindow.Open();
            accEditorWindow.FillTextBoxes(dateBaseConnector.CurrentFirstName, dateBaseConnector.CurrentLastName,
                                      dateBaseConnector.CurrentUserLogin, dateBaseConnector.CurrentPassword);
        }
    }

    private void NewArray_Click(object o, EventArgs e)
    {
        workDesk.WorkField.Clear();
        arrayEditor.ClearArray();
        dateBaseConnector.CurrentArray = "";
    }
    private void ExitFromAcc_Click(object o, EventArgs e)
    {
        workDesk.Close();
        enterWindow.Open();
    }
    private void OpenArray_Click(object o, EventArgs e)
    {
        openArrayWindow.Open();
        workDesk.Close();
        openArrayWindow.AddButtons(dateBaseConnector.UserArrays);
    }
    private void SaveArray_Click(object o, EventArgs e)
    {
        if (arrayEditor.AddNumbersFromString(workDesk.WorkField.Text))
        {
            if (dateBaseConnector.CurrentArray.Length == 0)
            {
                saveArrayAsWindow.Open();
                workDesk.Close();
                saveArrayAsWindow.AddButtons(dateBaseConnector.UserArrays);
            }
            else
            {
                if (dateBaseConnector.UpdateArray(arrayEditor.GetStringSourceArray(), dateBaseConnector.CurrentArray))
                {
                    MessageBox.Show("The save is success!", "Info");
                }
                else
                {
                    MessageBox.Show("The save is not success!", "Info");
                }
            }
        }
        else
        {
            MessageBox.Show("Array has not numbers!", "Info");
        }
    }
    private void SaveArrayAs_Click(object o, EventArgs e)
    {
        saveArrayAsWindow.Open();
        workDesk.Close();
        saveArrayAsWindow.AddButtons(dateBaseConnector.UserArrays);
    }
    private void DeleteArray_Click(object o, EventArgs e)
    {
        deleteArrayWindow.Open();
        workDesk.Close();
        deleteArrayWindow.AddButtons(dateBaseConnector.UserArrays);
    }

    private void EnterToEditAcc_Click(object o, EventArgs e)
    {
        
        accEditorWindow.Open();
        workDesk.Close();
    }

    private void ShowSortedArray_Click(object o, EventArgs e)
    {
        if (arrayEditor.AddNumbersFromString(workDesk.WorkField.Text))
        {
            workDesk.WorkField.Text = arrayEditor.GetStringSortedArray();
        }
        else
        {
            MessageBox.Show("¬веден не подход€щий формат!", "Error");
        }
    }
    private void ShowSourceArray_Click(object o, EventArgs e)
    {
        if (arrayEditor.AddNumbersFromString(workDesk.WorkField.Text))
        {
            workDesk.WorkField.Text = arrayEditor.GetStringSourceArray();
        }
        else
        {
            MessageBox.Show("¬веден не подход€щий формат!", "Error");
        }
    }
    private void FillRandomNumber_Click(object o, EventArgs e)
    {
        int firstLimit;
        int secondLimit;
        uint quantity;
        if (int.TryParse(windowRandomNambers.firstLimitBox.Text, out firstLimit) &&
            int.TryParse(windowRandomNambers.lastLimitBox.Text, out secondLimit) &&
            uint.TryParse(windowRandomNambers.Quantity.Text, out quantity))
        {
            arrayEditor.AddRandomNumbers(quantity, firstLimit, secondLimit);
            workDesk.WorkField.Text = arrayEditor.GetStringSourceArray();
            windowRandomNambers.Close(); arrayEditWindow.Open();
        }
        else if (!uint.TryParse(windowRandomNambers.Quantity.Text, out quantity) &&
            (int.TryParse(windowRandomNambers.lastLimitBox.Text, out firstLimit) ||
             int.TryParse(windowRandomNambers.firstLimitBox.Text, out secondLimit)))
        {
            MessageBox.Show("¬ведено отрицательное количество!", "Error");
        }
        else
        {
            MessageBox.Show("¬ведены не целые числа!", "Error");
        }
    }
    private void DownloadArray_Click(object o, EventArgs e)
    {
        workDesk.Close();
        downloadArrayWindow.Open();
        downloadArrayWindow.AddButtons(dateBaseConnector.UserArrays);
    }
    private void Clear_Click(object o, EventArgs e)
    {
        workDesk.WorkField.Clear();
    }

    private void OpenRandomNumberWindow_Click(object o, EventArgs e)
    {
        arrayEditWindow.Close();
        windowRandomNambers.Open();
    }
    private void ExitFormRandNumWindow_Click(object o, EventArgs e)
    {
        windowRandomNambers.Close();
        arrayEditWindow.Open();
    }

    private void ChoiceArrayForSave_Click(object o, EventArgs e)
    {
        if (arrayEditor.AddNumbersFromString(workDesk.WorkField.Text))
        {
            if (dateBaseConnector.AddArray(workDesk.WorkField.Text, saveArrayAsWindow.LastNameBox.Text))
            {
                saveArrayAsWindow.Close();
                workDesk.Open();
                MessageBox.Show("New array was added!", "Info");
            }
            else
            {
                if (dateBaseConnector.UpdateArray(workDesk.WorkField.Text, saveArrayAsWindow.LastNameBox.Text))
                {
                    saveArrayAsWindow.Close();
                    workDesk.Open();
                    MessageBox.Show("Array " + saveArrayAsWindow.LastNameBox.Text + " was added!", "Info");
                }
                else
                {
                    MessageBox.Show("This array not exist!", "Info");
                }
            }
        }
        else
        {
            MessageBox.Show("Array has not numbers!", "Info");
        }
    }
    private void CancelSaveArrayAs_Click(object o, EventArgs e)
    {
        saveArrayAsWindow.Close();
        workDesk.Open();
    }

    private void CancelOpenArray_Click(object o, EventArgs e)
    {
        workDesk.Open();
        openArrayWindow.Close();
    }
    private void ChoiceArrayForOpen_Click(object o, EventArgs e)
    {
        string ArrayString;
        if (dateBaseConnector.GetArrayFromDB(out ArrayString, openArrayWindow.LastNameBox.Text))
        {
            workDesk.WorkField.Text = ArrayString;
            openArrayWindow.Close();
            workDesk.Open();
            MessageBox.Show("Operation is success!", "Info");
        }
        else
        {
            MessageBox.Show("This array not exist!", "Info");
        }

    }

    private void ChoiceArrayForDownload_Click(object o, EventArgs e)
    {
        string ArrayString;
        if (dateBaseConnector.GetArrayFromDB(out ArrayString, downloadArrayWindow.LastNameBox.Text))
        {
            workDesk.WorkField.Text += ArrayString;
            openArrayWindow.Close();
            workDesk.Open();
            MessageBox.Show("Operation is success!", "Info");
        }
        else
        {
            MessageBox.Show("This array not exist!", "Info");
        }
    }
    private void CancelDownloadArray_Click(object o, EventArgs e)
    {
        workDesk.Open();
        downloadArrayWindow.Close();
    }

    private void ChoiceArrayForDelete_Click(object o, EventArgs e)
    {
        if (dateBaseConnector.DeleteArray(deleteArrayWindow.LastNameBox.Text))
        {
            deleteArrayWindow.Close();
            workDesk.Open();
            MessageBox.Show("Operation is success!", "Info");
        }
        else
        {
            MessageBox.Show("This array not exist!", "Info");
        }
    }
    private void CancelDeleteArray_Click(object o, EventArgs e)
    {
        deleteArrayWindow.Close();
        workDesk.Open();
    }

    private void BackToWorkDesk_Click(object o, EventArgs e)
    {
        accEditorWindow.FillTextBoxes(dateBaseConnector.CurrentFirstName, dateBaseConnector.CurrentLastName,
                                      dateBaseConnector.CurrentUserLogin, dateBaseConnector.CurrentPassword);
        workDesk.Open();
        accEditorWindow.Close();
    }
    private void Apply_Click(object o, EventArgs e)
    {
        if(dateBaseConnector.ChangeUserData(dateBaseConnector.CurrentUserLogin, accEditorWindow.FirstNameTextBox.Text, 
            accEditorWindow.LastNameTextBox.Text, accEditorWindow.LoginTextBox.Text, accEditorWindow.PasswordTextBox.Text))
        {
            accEditorWindow.Close();
            workDesk.Open();
            workDesk.ChangeName(dateBaseConnector.CurrentUserLogin);
            MessageBox.Show("Operation is success!", "Info");
        }
        else
        {
            MessageBox.Show("Operation is not success!", "Info");
        }
    }
    private void DeleteAcc_Click(object o, EventArgs e)
    {
        if(dateBaseConnector.DeleteUser(dateBaseConnector.CurrentUserLogin))
        {
            accEditorWindow.Close();
            enterWindow.Open();
            MessageBox.Show("Operation is success!", "Info");
        }
        else
        {
            MessageBox.Show("Operation is not success!", "Info");
        }
    }
}

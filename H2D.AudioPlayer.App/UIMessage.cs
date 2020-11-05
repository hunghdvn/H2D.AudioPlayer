using System;
using System.Windows.Forms;

namespace H2D.AudioPlayer.App
{
    public static class UIMessage
    {
        public static void ShowMessage(string message, string caption = "Infomation")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(string message, string caption = "Error")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowException(this Exception ex, string caption = "Error")
        {
            MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarning(string message, string caption = "Warning")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowQuestion(string caption, string message, MessageBoxButtons buttons = MessageBoxButtons.OKCancel)
        {
            return MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
        }

        public static DialogResult ShowQuestion(string message, MessageBoxButtons buttons = MessageBoxButtons.OKCancel)
        {
            return ShowQuestion("Choose one", message, buttons);
        }

        public static void ShowWarningWithFocusControl(string message, Control control)
        {
            ShowWarning(message);
            control.Focus();
        }
    }
}

using System.Windows.Forms;

namespace prj2.Classes
{
  public static class Alert
  {
    /// <summary>
    /// 警告訊息.
    /// </summary>
    /// <param name="chinese">中文顯示訊息.</param>
    /// <param name="english">英文顯示訊息.</param>
    public static void wBox(string chinese, string english = "Invalid data.")
    {
      MessageBox.Show(chinese + "\r\n" + english, "FJCU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    /// <summary>
    /// 完成訊息.
    /// </summary>
    /// <param name="chinese">中文訊息</param>
    /// <param name="english">英文訊息，預設為"Successfully"</param>
    public static void iBox(string chinese, string english = "Successfully")
    {
      MessageBox.Show(chinese + "\r\n" + english, "FJCU", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// 當使用者執行具有風險性的動作，如對資料表的新增、更新、刪除等動作，按照Coding Style規範，編寫詢問視窗.
    /// </summary>
    /// <param name="chinese">傳入中文字串.</param>
    /// <param name="english">傳入英文字串.</param>
    /// <returns>返回使用者按下按鍵(是或否)的結果.</returns>
    public static DialogResult qBox(string chinese, string english)
    {
      DialogResult result = MessageBox.Show(chinese + "\r\n" + english, "FJCU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      return result;
    }
  }
}

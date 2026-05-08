#if UNITY_EDITOR
using UnityEditor;

[InitializeOnLoad]
public static class UtilsRepositoryInstallDialog
{
    static UtilsRepositoryInstallDialog()
    {
        if (!EditorPrefs.GetBool("UtilsRepository_InstallDialogShown", false))
        {
            EditorPrefs.SetBool("UtilsRepository_InstallDialogShown", true);
            EditorApplication.update += ShowDialog;
        }
    }

    private static void ShowDialog()
    {
        EditorApplication.update -= ShowDialog;
        EditorUtility.DisplayDialog(
            "Utils.Repository",
            "Cài đặt package Utils.Repository thành công!\n\nBạn đã sẵn sàng sử dụng các tiện ích.",
            "OK"
        );
    }
}
#endif
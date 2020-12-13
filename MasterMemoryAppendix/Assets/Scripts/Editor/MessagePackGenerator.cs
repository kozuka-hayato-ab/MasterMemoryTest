using System.Diagnostics;
using UnityEditor;
using UnityEngine;

public class MessagePackGenerator
{
    [MenuItem("MessagePack/CodeGenerate")]
    private static void GenerateMessagePack()
    {
        ExecuteMessagePackCodeGenerator();
    }

    private static void ExecuteMessagePackCodeGenerator()
    {
        UnityEngine.Debug.Log($"{nameof(ExecuteMessagePackCodeGenerator)} : start");

        var exProcess = new Process();

        var rootPath = Application.dataPath + "/..";
        var filePath = rootPath + "/GeneratorTools/mpc";
        var exeFileName = "";
#if UNITY_EDITOR_WIN
        exeFileName = "/win/mpc.exe";
#elif UNITY_EDITOR_OSX
        exeFileName = "/osx/mpc";
#elif UNITY_EDITOR_LINUX
        exeFileName = "/linux/mpc";
#else
        return;
#endif

        var psi = new ProcessStartInfo()
        {
            CreateNoWindow = true,
            WindowStyle = ProcessWindowStyle.Hidden,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            FileName = filePath + exeFileName,
            // TODO: 使用する場合はPathを変更してください
            Arguments =
                $@"-i ""{Application.dataPath}/Scripts/TableDefines"" -o ""{Application.dataPath}/Scripts/Generated/MessagePack""",
        };

        var p = Process.Start(psi);

        p.EnableRaisingEvents = true;
        p.Exited += (object sender, System.EventArgs e) =>
        {
            var data = p.StandardOutput.ReadToEnd();
            UnityEngine.Debug.Log($"{data}");
            UnityEngine.Debug.Log($"{nameof(ExecuteMessagePackCodeGenerator)} : end");
            p.Dispose();
            p = null;
        };
    }
}
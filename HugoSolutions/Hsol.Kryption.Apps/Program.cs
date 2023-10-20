using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using Hsol.Kryption.Apps.Helpers;
using System.Runtime.InteropServices;

namespace Hsol.Kryption.Apps
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region `원본 엔트리 실행영역`
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #endregion

            #region `솔루션 초기화영역`
            string _plantCode, _userId, _userName = string.Empty;
            // 싱글톤 처리 복잡하게 함
            Configuration solutionConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // 재시작이면 로그인 않고 다시시작
            if (CheckDuplicationProcess()) return;

            if (solutionConfig.AppSettings.Settings["status"].Value.Equals("START"))
            {
                if (DialogResult.OK != new FrmLogin().DialogResult) return;
            }

            #endregion

            // 실제 폼 실행 - 변경요
            //Application.Run(new FrmMain());
        }

        /// <summary>
        /// 중복 프로세스 확인
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private static bool CheckDuplicationProcess()
        {
            var currProcess = Process.GetCurrentProcess();
            var id = currProcess.Id;
            var processName = currProcess.ProcessName;

            // 현재 프로그램과 같은 프로그램 수집
            List<Process> processes = Process.GetProcessesByName(processName).ToList();
            
            foreach (Process process in processes)
            {
                if (process.Id == id) continue;

                // WinAPI 처리
                ShowWindow(process.MainWindowHandle, 1);
                BringWindowToTop(process.MainWindowHandle);
                SetForegroundWindow(process.MainWindowHandle);

                return true;
            }

            return false;
        }

        #region `Win32 API`

        [DllImport("user32")]
        public static extern void BringWindowToTop(IntPtr hWnd);

        [DllImport("User32", EntryPoint = "SetForegroundWindow")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("User32")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        #endregion
    }
}

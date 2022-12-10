using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtorization
{
    public partial class animateComponent : Component
    {

        #region[поля класса ]
        private Form _sourceForm;
        private animate _closeEffect = animate.появление_затухание;
        private animate _activateEffect = animate.раскрытие_скрытие;
        #endregion
        #region[Свойства класса ]
        public animate CloseEffect
        {
            get => _closeEffect;
            set => _closeEffect = value;
        }
        public animate ActivateEffect
        {
            get => _activateEffect;
            set => _activateEffect = value;
        }
        public Control SourceForm
        {
            get => _sourceForm;
            set
            {
                if (value is Form)
                    _sourceForm = (value as Form);
            }
        }
        #endregion
        public animateComponent()
        {
            InitializeComponent();
        }

        public animateComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #region[Методы]
        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, uint flags);

        public void ShowForm(int millisecond)
        {
            AnimateWindow(_sourceForm.Handle, millisecond, (uint)_activateEffect | 0x00020000);
            _sourceForm.Show();
        }
        public void CloseForm(int millisecond)
        {
            AnimateWindow(_sourceForm.Handle, millisecond, (uint)_closeEffect | 0x00010000);
            _sourceForm.Close();
        }
        #endregion
    }
}

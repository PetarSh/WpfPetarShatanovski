// Updated by XamlIntelliSenseFileGenerator 21.3.2022 09:50:53
#pragma checksum "..\..\..\View\ClientCollection.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "31A7C347DA9675F8B5857A2D6D3FCDD04D79FF0FD12E7144833CF3EC237085E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfPetarShatanovski.Infrastructure;
using WpfPetarShatanovski.View;
using WpfPetarShatanovski.ViewModel;


namespace WpfPetarShatanovski.View
{


    /// <summary>
    /// ClientCollection
    /// </summary>
    public partial class ClientCollection : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {


#line 52 "..\..\..\View\ClientCollection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameNew;

#line default
#line hidden


#line 53 "..\..\..\View\ClientCollection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameNew;

#line default
#line hidden


#line 54 "..\..\..\View\ClientCollection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker BirthDateNew;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfPetarShatanovski;component/view/clientcollection.xaml", System.UriKind.Relative);

#line 1 "..\..\..\View\ClientCollection.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.FirstNameNew = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.LastNameNew = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.BirthDateNew = ((System.Windows.Controls.DatePicker)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.ListBox lstBox;
    }
}


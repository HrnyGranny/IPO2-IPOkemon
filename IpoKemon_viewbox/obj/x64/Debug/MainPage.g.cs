﻿#pragma checksum "C:\Users\aitor\OneDrive\Desktop\Nueva carpeta (2)\IpoKemon-main\IpoKemon_viewbox\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8A9704D96EC3F68EDBF63BEBCF0121E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IpoKemon_viewbox
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 28
                {
                    this.sView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // MainPage.xaml line 69
                {
                    this.fmMain = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 4: // MainPage.xaml line 49
                {
                    this.btnInicio = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnInicio).Click += this.btnInicio_Click;
                }
                break;
            case 5: // MainPage.xaml line 53
                {
                    this.btnPokedex = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPokedex).Click += this.btnPokedex_Click;
                }
                break;
            case 6: // MainPage.xaml line 56
                {
                    this.btnCombate = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCombate).Click += this.btnCombate_Click;
                }
                break;
            case 7: // MainPage.xaml line 59
                {
                    this.btnAjustes = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAjustes).Click += this.btnAjustes_Click;
                }
                break;
            case 8: // MainPage.xaml line 62
                {
                    this.btnAyuda = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAyuda).Click += this.btnAyuda_Click;
                }
                break;
            case 9: // MainPage.xaml line 23
                {
                    this.btnMenu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnMenu).Click += this.btnMenu_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


﻿#pragma checksum "C:\Users\aitor\OneDrive\Desktop\Nueva carpeta (2)\IpoKemon-main\IpoKemon_viewbox\PokeDex.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7A728693BEFE591F0A61968CEFEAC67D"
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
    partial class PokeDex : 
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
            case 2: // PokeDex.xaml line 11
                {
                    this.Pokedex = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // PokeDex.xaml line 41
                {
                    this.Titulo_img = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // PokeDex.xaml line 44
                {
                    this.btnGengar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnGengar).Click += this.btnGengar_Click;
                }
                break;
            case 5: // PokeDex.xaml line 35
                {
                    this.btnCharmander = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCharmander).Click += this.btnCharmander_Click;
                }
                break;
            case 6: // PokeDex.xaml line 27
                {
                    this.btnAron = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAron).Click += this.btnAron_Click;
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

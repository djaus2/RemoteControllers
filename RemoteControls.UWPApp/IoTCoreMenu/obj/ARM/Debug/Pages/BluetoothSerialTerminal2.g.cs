﻿#pragma checksum "C:\Users\david\Documents\Visual Studio 2015\Projects\IoTCoreMenu2\IoTCoreMenu\Pages\BluetoothSerialTerminal2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4B7B6689A2FA3FB1DEA65DFC7D8303ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IoTCoreMenu
{
    partial class BluetoothSerialTerminalPage2 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.PairedDevices = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 2:
                {
                    this.MyTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.uartTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.status = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.buttonSend = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 104 "..\..\..\Pages\BluetoothSerialTerminal2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonSend).Click += this.button_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.buttonCancelSend = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 105 "..\..\..\Pages\BluetoothSerialTerminal2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonCancelSend).Click += this.button_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.buttonClearSend = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 106 "..\..\..\Pages\BluetoothSerialTerminal2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonClearSend).Click += this.button_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.recvdText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.buttoncomPortConnect = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 87 "..\..\..\Pages\BluetoothSerialTerminal2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttoncomPortConnect).Click += this.button_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.buttonDisconnect = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 88 "..\..\..\Pages\BluetoothSerialTerminal2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonDisconnect).Click += this.button_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.ButtonRefresh = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 89 "..\..\..\Pages\BluetoothSerialTerminal2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonRefresh).Click += this.button_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.buttonStartRecv = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 90 "..\..\..\Pages\BluetoothSerialTerminal2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonStartRecv).Click += this.button_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.buttonStopRecv = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 91 "..\..\..\Pages\BluetoothSerialTerminal2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonStopRecv).Click += this.button_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.textBoxSendText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15:
                {
                    this.ConnectDevices = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 69 "..\..\..\Pages\BluetoothSerialTerminal2.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.ConnectDevices).DoubleTapped += this.ConnectDevices_DoubleTapped;
                    #line 69 "..\..\..\Pages\BluetoothSerialTerminal2.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.ConnectDevices).SelectionChanged += this.ConnectDevices_SelectionChanged;
                    #line default
                }
                break;
            case 16:
                {
                    this.buttonBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 65 "..\..\..\Pages\BluetoothSerialTerminal2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonBack).Click += this.button_Click;
                    #line default
                }
                break;
            case 17:
                {
                    this.BTName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.textBlockBTName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    this.ID = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20:
                {
                    this.TxtBlock_SelectedID = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


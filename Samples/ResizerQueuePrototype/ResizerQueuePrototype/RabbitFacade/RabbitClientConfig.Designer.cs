﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RabbitFacade {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class RabbitClientConfig : global::System.Configuration.ApplicationSettingsBase {
        
        private static RabbitClientConfig defaultInstance = ((RabbitClientConfig)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new RabbitClientConfig())));
        
        public static RabbitClientConfig Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("f4me-dev-01.cloudapp.net")]
        public string RabbitHost {
            get {
                return ((string)(this["RabbitHost"]));
            }
            set {
                this["RabbitHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string RabbitPort {
            get {
                return ((string)(this["RabbitPort"]));
            }
            set {
                this["RabbitPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("f4rabbit")]
        public string RabbitUser {
            get {
                return ((string)(this["RabbitUser"]));
            }
            set {
                this["RabbitUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1qaz@WSX3edc")]
        public string RabbitPassword {
            get {
                return ((string)(this["RabbitPassword"]));
            }
            set {
                this["RabbitPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("imagesToProcess")]
        public string Queue_ImagesToProcess {
            get {
                return ((string)(this["Queue_ImagesToProcess"]));
            }
            set {
                this["Queue_ImagesToProcess"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("emailsToSend")]
        public string Queue_EmailsToSend {
            get {
                return ((string)(this["Queue_EmailsToSend"]));
            }
            set {
                this["Queue_EmailsToSend"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/")]
        public string DefaultVirtualHost {
            get {
                return ((string)(this["DefaultVirtualHost"]));
            }
            set {
                this["DefaultVirtualHost"] = value;
            }
        }
    }
}
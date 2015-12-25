﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReusableLibrary.Web.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ReusableLibrary.Web.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE HTML PUBLIC &quot;-//W3C//DTD HTML 4.0 Transitional//EN&quot;&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;title&gt;Denied Mail&lt;/title&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;div style=&quot;font-family: Tahoma, Monospace; font-size: 8pt;&quot;&gt;
        ///        This message indicates that the
        ///        &lt;%= Application%&gt;
        ///        application has detected denial-of-service attack. The
        ///        matching condition was &lt;b&gt;
        ///            &lt;%= ErrorRate%&gt;&lt;/b&gt; errors during &lt;b&gt;
        ///                &lt;%= ThrottlePeriod%&gt;&lt;/b&gt;. The following hosts &lt;b&gt;
        ///                    &lt;%= Hosts% [rest of string was truncated]&quot;;.
        /// </summary>
        public static string DeniedMailBody {
            get {
                return ResourceManager.GetString("DeniedMailBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} DoS Attack ({1}).
        /// </summary>
        public static string ErrorThrottleMailSubject {
            get {
                return ResourceManager.GetString("ErrorThrottleMailSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forms cookie is not available..
        /// </summary>
        public static string FormsAuthenticationServiceFormsCookie {
            get {
                return ResourceManager.GetString("FormsAuthenticationServiceFormsCookie", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Increment operation is session state is not valid..
        /// </summary>
        public static string SessionCacheIncrementNotValid {
            get {
                return ResourceManager.GetString("SessionCacheIncrementNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request unique token &apos;{0}&apos; was not supplied..
        /// </summary>
        public static string UniqueTokenHelperNotFound {
            get {
                return ResourceManager.GetString("UniqueTokenHelperNotFound", resourceCulture);
            }
        }
    }
}

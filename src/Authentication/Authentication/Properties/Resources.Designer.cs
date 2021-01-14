﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Graph.PowerShell.Authentication.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access to the path &apos;{0}&apos; is denied..
        /// </summary>
        internal static string AccessDenied {
            get {
                return ResourceManager.GetString("AccessDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cmdlet cannot run because the following parameter is not specified: {0} The supplied Authentication type requires a {1} Specify {1}, then retry..
        /// </summary>
        internal static string AuthenticationCredentialNotSupplied {
            get {
                return ResourceManager.GetString("AuthenticationCredentialNotSupplied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cmdlet cannot run because the following conflicting parameters are specified: {0} and Token. Specify either {0} or {1} then retry..
        /// </summary>
        internal static string AuthenticationTokenConflict {
            get {
                return ResourceManager.GetString("AuthenticationTokenConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cmdlet cannot run because the following conflicting parameters are specified: {0} and {1} Specify either {0} or {1}, then retry..
        /// </summary>
        internal static string BodyConflict {
            get {
                return ResourceManager.GetString("BodyConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is required when Method is {1}.
        /// </summary>
        internal static string BodyMissingWhenMethodIsSpecified {
            get {
                return ResourceManager.GetString("BodyMissingWhenMethodIsSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Content encoding: {0}.
        /// </summary>
        internal static string ContentEncodingVerboseMessage {
            get {
                return ResourceManager.GetString("ContentEncodingVerboseMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cmdlet cannot run because the -ContentType parameter is not a valid Content-Type header. Specify a valid Content-Type for -ContentType, then retry. To suppress header validation, supply the -SkipHeaderValidation parameter..
        /// </summary>
        internal static string ContentTypeExceptionErrorMessage {
            get {
                return ResourceManager.GetString("ContentTypeExceptionErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path &apos;{0}&apos; resolves to a directory. Specify a path including a file name, and then retry the command..
        /// </summary>
        internal static string DirectoryPathSpecified {
            get {
                return ResourceManager.GetString("DirectoryPathSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot convert the JSON string because a dictionary that was converted from the string contains the duplicated key &apos;{0}&apos;..
        /// </summary>
        internal static string DuplicateKeysInJsonString {
            get {
                return ResourceManager.GetString("DuplicateKeysInJsonString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided JSON includes a property whose name is an empty string, this is only supported using the -OutputType HashTable switch..
        /// </summary>
        internal static string EmptyKeyInJsonString {
            get {
                return ResourceManager.GetString("EmptyKeyInJsonString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cmdlet cannot run because the following conflicting parameters are specified: GraphRequestSession and SessionVariable. Specify either GraphRequestSession or SessionVariable, then retry..
        /// </summary>
        internal static string GraphRequestSessionConflict {
            get {
                return ResourceManager.GetString("GraphRequestSessionConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Http Message Invalid Media Type {0}.
        /// </summary>
        internal static string HttpMessageInvalidMediaType {
            get {
                return ResourceManager.GetString("HttpMessageInvalidMediaType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cmdlet cannot run because the following conflicting parameters are specified: {0} and {1}. Specify either {0} or {1} then retry..
        /// </summary>
        internal static string InferFileNameOutFilePathConflict {
            get {
                return ResourceManager.GetString("InferFileNameOutFilePathConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not Infer File Name.
        /// </summary>
        internal static string InferredFileNameErrorMessage {
            get {
                return ResourceManager.GetString("InferredFileNameErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inferred File Name {0} Saving to {1}.
        /// </summary>
        internal static string InferredFileNameVerboseMessage {
            get {
                return ResourceManager.GetString("InferredFileNameVerboseMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Host {0}.
        /// </summary>
        internal static string InvokeGraphRequestInvalidHostErrorMessage {
            get {
                return ResourceManager.GetString("InvokeGraphRequestInvalidHostErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty string not allowed for {0}.
        /// </summary>
        internal static string InvokeGraphRequestInvalidUriErrorMessage {
            get {
                return ResourceManager.GetString("InvokeGraphRequestInvalidUriErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must specify {0}.
        /// </summary>
        internal static string InvokeGraphRequestMissingUriErrorMessage {
            get {
                return ResourceManager.GetString("InvokeGraphRequestMissingUriErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} {1} with {2}-byte payload.
        /// </summary>
        internal static string InvokeGraphRequestVerboseMessage {
            get {
                return ResourceManager.GetString("InvokeGraphRequestVerboseMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to received {0}-byte response of content type {1}.
        /// </summary>
        internal static string InvokeGraphResponseVerboseMessage {
            get {
                return ResourceManager.GetString("InvokeGraphResponseVerboseMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Conversion from JSON failed with error: {0}.
        /// </summary>
        internal static string JsonDeserializationFailed {
            get {
                return ResourceManager.GetString("JsonDeserializationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Conversion from JSON failed with error: {0}.
        /// </summary>
        internal static string JsonSerializationFailed {
            get {
                return ResourceManager.GetString("JsonSerializationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot convert the JSON string because it contains keys with different casing. Please use the -OutputType HashTable switch instead. The key that was attempted to be added to the existing key &apos;{0}&apos; was &apos;{1}&apos;..
        /// </summary>
        internal static string KeysWithDifferentCasingInJsonString {
            get {
                return ResourceManager.GetString("KeysWithDifferentCasingInJsonString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cmdlet cannot run because {0} is missing and &apos;Authentication&apos; is set to &apos;Default&apos;. Please call &apos;Connect-Graph&apos; then try again..
        /// </summary>
        internal static string MissingAuthenticationContext {
            get {
                return ResourceManager.GetString("MissingAuthenticationContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path &apos;{0}&apos; can be resolved to multiple paths..
        /// </summary>
        internal static string MultiplePathsResolved {
            get {
                return ResourceManager.GetString("MultiplePathsResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path &apos;{0}&apos; cannot be resolved to a file..
        /// </summary>
        internal static string NoPathResolved {
            get {
                return ResourceManager.GetString("NoPathResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cmdlet cannot run because Authentication is set to {0} and Connect-Graph was not called. Invoke &apos;Connect-Graph&apos; or specify Authentication to be &apos;UserProvidedToken&apos; and Provide a Token then retry.
        /// </summary>
        internal static string NotConnectedToGraphException {
            get {
                return ResourceManager.GetString("NotConnectedToGraphException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path &apos;{0}&apos; is not a file system path. Please specify the path to a file in the file system..
        /// </summary>
        internal static string NotFileSystemPath {
            get {
                return ResourceManager.GetString("NotFileSystemPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} specified without {1}.  If {0} is specified {1} must be specified as well..
        /// </summary>
        internal static string PassThruWithOutputFilePathMissing {
            get {
                return ResourceManager.GetString("PassThruWithOutputFilePathMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Response status code does not indicate success: {0} ({1})..
        /// </summary>
        internal static string ResponseStatusCodeFailure {
            get {
                return ResourceManager.GetString("ResponseStatusCodeFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Graph Request completed. (Number of bytes processed: {0}).
        /// </summary>
        internal static string WriteRequestComplete {
            get {
                return ResourceManager.GetString("WriteRequestComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of bytes processed: {0}.
        /// </summary>
        internal static string WriteRequestProgressStatus {
            get {
                return ResourceManager.GetString("WriteRequestProgressStatus", resourceCulture);
            }
        }
    }
}

namespace APTCA.Annotations
{
    using System;
    using static System.AttributeTargets;

    /// <summary>
    /// Indicates, that specified member has been properly secured for partially trusted callers
    /// </summary>
    [AttributeUsage(validOn: Constructor | Method | Property | Event, AllowMultiple = false, Inherited = false)]
    public class SecuredForPartialTrustAttribute: Attribute{}
}

namespace IfLoooop.Utilities.Singleton
{
    /// <summary>
    /// Specifies the method in which the singleton instance should be initialized.
    /// </summary>
    public enum InitializationMethod
    {
        /// <summary>
        /// Will be initialized in the Awake method.
        /// </summary>
        Awake,
        /// <summary>
        /// Will be initialized in the OnEnable method.
        /// </summary>
        OnEnable,
        /// <summary>
        /// Will be initialized in the Start method.
        /// </summary>
        Start,
#if UNITY_EDITOR
        /// <summary>
        /// Will be initialized in the OnValidate method. <br/>
        /// <b>Works only in  editor.</b>
        /// </summary>
        OnValidate
#endif
    }
}
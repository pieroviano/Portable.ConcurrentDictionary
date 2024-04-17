using System.Reflection;
namespace System.Collections.Generic
{
#if NET20 || NET30 || NET35 || NET40 || PORTABLE
    /// <summary>
    /// Represents a generic read-only collection of key/value pairs.
    /// </summary>
    /// <typeparam name="TKey">
    /// The type of keys in the read-only dictionary.
    /// </typeparam>
    /// <typeparam name="TValue">
    /// The type of values in the read-only dictionary.
    /// </typeparam>
    //[DefaultMember("Item")]
    public interface IReadOnlyDictionary<TKey, TValue> 
        : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
    {
        
        /// <summary>
        /// Gets the element that has the specified key in the read-only dictionary.
        /// </summary>
        /// <param name="key">
        /// The key to locate.
        /// </param>
        /// <returns>
        /// The element that has the specified key in the read-only dictionary.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// key is null.
        /// </exception>
        /// <exception cref="KeyNotFoundException">
        /// The property is retrieved and key is not found.
        /// </exception>
        TValue this[TKey key] { get; }

        /// <summary>
        /// Gets an enumerable collection that contains the keys in the read-only dictionary.
        /// </summary>
        /// <returns>
        /// An enumerable collection that contains the keys in the read-only dictionary.
        /// </returns>
        IEnumerable<TKey> Keys { get; }
     
        /// <summary>
        /// Gets an enumerable collection that contains the values in the read-only dictionary.
        /// </summary>
        /// <returns>
        /// An enumerable collection that contains the values in the read-only dictionary.
        /// </returns>
        IEnumerable<TValue> Values { get; }

        /// <summary>
        /// Determines whether the read-only dictionary contains an element that has the specified key.
        /// </summary>
        /// <param name="key">
        /// The key to locate.
        /// </param>
        /// <returns>
        /// true if the read-only dictionary contains an element that has the specified key;
        ///    otherwise, false.
        /// </returns>
        bool ContainsKey(TKey key);

        /// <summary>
        /// Gets the value that is associated with the specified key.
        /// </summary>
        /// <param name="key">The key to locate.</param>
        /// <param name="value">
        /// When this method returns, the value associated with the specified key, if the
        ///    key is found; otherwise, the default value for the type of the value parameter.
        ///    This parameter is passed uninitialized.
        /// </param>
        /// <returns>
        /// true if the object that implements the System.Collections.Generic.IReadOnlyDictionary`2
        ///    interface contains an element that has the specified key; otherwise, false.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// key is null.
        /// </exception>
        bool TryGetValue(TKey key, out TValue value);
    }
#endif
}
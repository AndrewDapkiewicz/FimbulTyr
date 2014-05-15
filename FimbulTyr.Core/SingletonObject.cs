using System;


namespace FimbulTyr.Core {

	public class SingletonObject<T> {

		private static T m_instance;		// Refers to the instance of the singleton

		/**
		 * Singleton getter.
		 */
		public static T Instance {
			get {
				if( m_instance == null ) {
					m_instance = new T();
				}
				return m_instance;
			}
		}
	}
}
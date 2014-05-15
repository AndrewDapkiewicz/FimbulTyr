using System;


namespace FimbulTyr.Core {

	public class CoreManager : SingletonObject<CoreManager> {

		// Wrapper manager for local data writing and retrieval
		private LocalStorageManager m_localStorageManager;
		public LocalStorageManager LocalStorageManager {
			get {
				return m_localStorageManager;
			}
		}


		/**
		 * Default constructor.
		 */
		public CoreManager() {

			// Create the local storage manager
			m_localStorageManager = new LocalStorageManager();
		}
	}
}
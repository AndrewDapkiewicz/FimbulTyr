using System;


namespace FimbulTyr.Core {

	public class User {

		private long m_userId;			// Id for server/database use

		private String m_firstName;		// User's first name
		private String m_lastName;		// User's last name

		private UserStatus m_status;	// User's status


		/**
		 * Default constructor.
		 */
		public User() {

		}

		/**
		 * Parameterized constructor accepts first name and last name.
		 */
		public User( String firstName, String lastName ) {
			m_firstName = firstName;
			m_lastName = lastName;
		}


		#region Properties

		public long UserId {
			get { return m_userId; }
			set { m_userId = value; }
		}

		public String FirstName {
			get { return m_firstName; }
			set { m_firstName = value; }
		}

		public String LastName {
			get { return m_lastName; }
			set { m_lastName = value; }
		}

		public UserStatus Status {
			get { return m_status; }
			set { m_status = value; }
		}

		#endregion
	}
}
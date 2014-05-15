using System;


namespace FimbulTyr.Core {

	public enum UserStatusState {
		USER_STATUS_ONLINE = 0,
		USER_STATUS_OFFLINE,
		USER_STATUS_AWAY,
		USER_STATUS_DISCONNECTED
	}

	public class UserStatus {
		 
		private UserStatusState m_state;	// Refers to an enum with the specified state
		private String m_message;			// (optional) Custom away message
		private Ticket m_ticketInProgress;	// (optional) Refers to the ticket the user is currently working on


		/**
		 * Default constructor.
		 */
		public UserStatus() {

		}


		#region Properties

		public UserStatusState State {
			get { return m_state; }
			set { m_state = value; }
		}

		public String Message {
			get { return m_message; }
			set { m_message = value; }
		}

		public Ticket TicketInProgress {
			get { return m_ticketInProgress; }
			set { m_ticketInProgress = value; }
		}

		#endregion
	}
}
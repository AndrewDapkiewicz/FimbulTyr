using System;


namespace FimbulTyr.Core {

	public class Ticket {

		private String m_title;			// Title of the ticket
		private String m_description;	// (optional) Description of the ticket
		private String m_label;			// (optional) Ticket label

		private User m_reporter;		// Person who created the ticket
		private User m_assignee;		// Person the ticket is assigned to

		private int m_priority;			// (optional) Priority level of the ticket

		private DateTime m_timestamp;	// Date and time the ticket was created
		private DateTime m_dueDate;		// (optional) Date and time the ticket is due


		/**
		 * Default constructor.
		 */
		public Ticket() {
			m_title = "<TITLE NOT SET>";
		}

		/**
		 * Parameterized constructor accepts all required fields.
		 */
		public Ticket( String title, User reporter, User assignee ) {
			m_title = title;
			m_reporter = reporter;
			m_assignee = assignee;
		}

		/**
		 * Parameterized constructor accepts all required fields and a description.
		 */
		public Ticket( String title, String description, User reporter, User assignee ) {
			m_title = title;
			m_description = description;
			m_reporter = reporter;
			m_assignee = assignee;
		}


		#region Properties

		public String Title {
			get { return m_title; }
			set { m_title = value; }
		}

		public String Description {
			get { return m_description; }
			set { m_description = value; }
		}

		public String Label {
			get { return m_label; }
			set { m_label = value; }
		}

		public User Reporter {
			get { return m_reporter; }
		}

		public User Assignee {
			get { return m_assignee; }
		}

		public int Priority {
			get { return m_priority; }
			set { m_priority = value; }
		}

		public DateTime Timestamp {
			get { return m_timestamp; }
		}

		public DateTime DueDate {
			get { return m_dueDate; }
			set { m_dueDate = value; }
		}

		#endregion
	}
}
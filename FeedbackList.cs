using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class FeedbackList
    {
        private readonly List<Feedback> _feedbackEntries;

        public FeedbackList()
        {
            // FetchFeedbackEntriesFromDatabase()
        }

        // Method to fetch feedback entries from the database
        void FetchFeedbackEntriesFromDatabase()
        {
            // Logic to retrieve feedback entries from the database and populate _feedbackEntries
        }

        // Method to get recent feedback entries
        public List<Feedback> GetRecentFeedbackEntries(int count)
        {
            // Return the most recent feedback entries based on the provided count
            return _feedbackEntries
                .OrderByDescending(f => f.FeedbackDate)
                .Take(count)
                .ToList();
        }
    }
}

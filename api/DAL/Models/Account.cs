using System;

namespace DAL.Models
{
    /// <summary>
    /// Represents a user account in the authentication system.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Unique identifier for the account.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Email address of the account.
        /// </summary>
        public string Email { get; set; } = null!;

        /// <summary>
        /// Indicates whether the email is verified.
        /// </summary>
        public bool EmailVerified { get; set; } = false;

        /// <summary>
        /// Display name of the user (optional).
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Status of the account (e.g., active, disabled).
        /// </summary>
        public string Status { get; set; } = "active";

        /// <summary>
        /// Timestamp when the account was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the account was last updated (optional).
        /// </summary>
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}

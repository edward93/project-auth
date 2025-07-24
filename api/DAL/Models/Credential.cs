using System;

namespace DAL.Models
{
    /// <summary>
    /// Represents a credential associated with an account for authentication.
    /// </summary>
    public class Credential
    {
        /// <summary>
        /// Unique identifier for the credential.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the associated account.
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// Unique credential identifier (binary).
        /// </summary>
        public byte[] CredentialId { get; set; } = null!;

        /// <summary>
        /// Public key for the credential (binary).
        /// </summary>
        public byte[] PublicKey { get; set; } = null!;

        /// <summary>
        /// Signature counter for the credential.
        /// </summary>
        public long SignCount { get; set; }

        /// <summary>
        /// Supported transports for the credential (optional).
        /// </summary>
        public string[]? Transports { get; set; }

        /// <summary>
        /// Authenticator Attestation GUID (optional).
        /// </summary>
        public Guid? Aaguid { get; set; }

        /// <summary>
        /// Type of the credential (optional).
        /// </summary>
        public string? CredentialType { get; set; }

        /// <summary>
        /// Attestation format (optional).
        /// </summary>
        public string? AttestationFormat { get; set; }

        /// <summary>
        /// Relying party identifier.
        /// </summary>
        public string RpId { get; set; } = null!;

        /// <summary>
        /// User handle (optional, binary).
        /// </summary>
        public byte[]? UserHandle { get; set; }

        /// <summary>
        /// Timestamp when the credential was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the credential was last updated (optional).
        /// </summary>
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}

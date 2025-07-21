
DO $$
BEGIN
  -- Create the auth schema
  CREATE SCHEMA IF NOT EXISTS auth;

  -- Set the owner of the schema
  GRANT ALL ON SCHEMA "auth" TO project_auth_api;
  -- Grant permissions to the user
  GRANT ALL ON ALL TABLES IN SCHEMA "auth" TO project_auth_api;
  GRANT ALL ON ALL SEQUENCES IN SCHEMA "auth" TO project_auth_api;
  GRANT ALL ON ALL FUNCTIONS IN SCHEMA "auth" TO project_auth_api;

  -- Enable extensions
  CREATE EXTENSION IF NOT EXISTS "pgcrypto";
  -- CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

  -- Accounts table
  CREATE TABLE IF NOT EXISTS auth.accounts 
  (
    id              UUID              NOT NULL PRIMARY KEY,
    email           TEXT              UNIQUE NOT NULL,
    email_verified  BOOLEAN           DEFAULT FALSE,
    display_name    TEXT              NULL,
    status          TEXT              DEFAULT 'active',

    created_at      TIMESTAMPTZ       NOT NULL,
    updated_at      TIMESTAMPTZ       NULL
  );

  -- Credentials table
  CREATE TABLE IF NOT EXISTS auth.credentials 
  (
    id                  UUID          NOT NULL PRIMARY KEY,
    account_id          UUID          REFERENCES auth.accounts(id),
    credential_id       BYTEA         UNIQUE NOT NULL,
    public_key          BYTEA         NOT NULL,
    sign_count          BIGINT        NOT NULL,
    transports          TEXT[]        NULL,
    aaguid              UUID          NULL,
    credential_type     TEXT          NULL,
    attestation_format  TEXT          NULL, 
    rp_id               TEXT          NOT NULL,
    user_handle         BYTEA         NULL,

    created_at          TIMESTAMPTZ   NOT NULL,
    updated_at          TIMESTAMPTZ   NULL
  );

  CREATE INDEX IF NOT EXISTS credential_user_handle_idx ON auth.credentials (user_handle);
  CREATE INDEX IF NOT EXISTS credential_credential_id_idx ON auth.credentials (credential_id);

  RAISE NOTICE 'Deployment is complete!';
END
$$;
-- This is used for testing purposes only.
-- It creates a database and user for the project authentication service.
-- In real applications, you would typically create the tables and schemas in the already existing database.
CREATE DATABASE "project-auth"
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LOCALE_PROVIDER = 'libc'
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;

CREATE USER project_auth_api WITH PASSWORD 'otxNXrw8bZqwYPHB5d8rv3fx';


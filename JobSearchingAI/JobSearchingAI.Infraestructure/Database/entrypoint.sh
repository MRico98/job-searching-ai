#!/bin/bash

/opt/mssql/bin/sqlservr &

echo "waiting for SQL server to start..."

sleep 10s

echo "Running database intialization script..."
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P password123! -d master -i init-db.sql

wait
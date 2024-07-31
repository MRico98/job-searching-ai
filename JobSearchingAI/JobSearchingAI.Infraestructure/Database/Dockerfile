FROM mcr.microsoft.com/mssql/server:2022-CU12-ubuntu-22.04

WORKDIR /temp

COPY . /temp

ENV MSSQL_SA_PASSWORD=password123!
ENV ACCEPT_EULA=Y
ENV MSSQL_PID=Express

EXPOSE 1433

CMD ["/bin/bash", "./entrypoint.sh"]
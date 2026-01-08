# Use official .NET SDK 8.0 image
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Set working directory
WORKDIR /app

# Install Allure commandline tool
RUN apt-get update && \
    apt-get install -y wget default-jre && \
    wget https://github.com/allure-framework/allure2/releases/download/2.24.1/allure-2.24.1.tgz && \
    tar -zxvf allure-2.24.1.tgz -C /opt/ && \
    ln -s /opt/allure-2.24.1/bin/allure /usr/bin/allure && \
    rm allure-2.24.1.tgz && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

# Copy project files for dependency caching
COPY StudentGradeApp/*.csproj ./StudentGradeApp/
COPY StudentGradeApp.Tests/*.csproj ./StudentGradeApp.Tests/

# Restore NuGet packages (this layer will be cached)
RUN dotnet restore StudentGradeApp.Tests/StudentGradeApp.Tests.csproj

# Set the working directory for builds
WORKDIR /workspace

# Default command
CMD ["/bin/bash"]

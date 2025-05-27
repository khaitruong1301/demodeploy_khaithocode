echo "🔄 Pulling latest code from GitHub..."
git pull

echo "🛑 Stopping and removing old container..."
docker stop my-api || true
docker rm my-api || true

echo "🐳 Building Docker image..."
docker build -t my-api .

echo "🚀 Starting new container..."
docker run -d -p 5000:80 \
  -v /home/ubuntu/wwwroot:/app/wwwroot \
  -e ASPNETCORE_ENVIRONMENT=Production \
  -e ASPNETCORE_URLS=http://+:80 \
  --name my-api \
  my-api

echo "✅ Deployed successfully!"
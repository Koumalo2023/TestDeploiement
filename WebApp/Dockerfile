# Build stage
FROM node:18 AS build
WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .
RUN npm run build:prod && ls -l /app/dist/web-app 

# Runtime stage
FROM nginx:alpine
COPY --from=build /app/dist/web-app /usr/share/nginx/html 
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
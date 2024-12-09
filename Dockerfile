FROM nginx:1.27.3-alpine
COPY ./nginx.conf /etc/nginx/conf.d/default.conf
COPY ./Web /usr/share/nginx/html

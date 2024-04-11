FROM node:16.13.1-alpine AS build-env

WORKDIR /app
COPY . .

RUN yarn && \
    node --max_old_space_size=4000 ./node_modules/@angular/cli/bin/ng build --prod --source-map=false --output-hashing=none

FROM nginx
COPY --from=build-env /app/dist /usr/share/nginx/html/

CMD ["nginx", "-g", "daemon off;"]
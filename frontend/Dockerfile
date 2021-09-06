FROM node:14-alpine

RUN mkdir -p /usr/src/app/frontend
WORKDIR /usr/src/app/frontend

COPY package*.json /usr/src/app/frontend
RUN npm install

COPY . /usr/src/app/frontend

EXPOSE 3000

CMD ["npm","start"]
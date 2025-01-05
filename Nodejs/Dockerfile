# ベースイメージとしてNode.jsのltsを使用
FROM node:lts

RUN apt-get update -y && \
    apt-get clean all

# 作業ディレクトリを設定
WORKDIR /opt/unity-nodejs

# ホスト側のsrcフォルダをコンテナ側の上記のWORKDIRにコピー
COPY ./src ./

RUN npm install

# nodemonでnodejsサーバを起動
CMD npm run dev
# ベースイメージとしてNode.jsのltsを使用
FROM node:lts

RUN apt-get update -y && \
    apt-get clean all

# 作業ディレクトリを設定
WORKDIR /opt/unity-nodejs

# ホスト側のNODEJSフォルダをコンテナ側の'/opt/unity-nodejs'ディレクトリにコピー
COPY ./package*.json .

RUN npm install

# コンテナを終了させないためのコマンド
CMD tail -f /dev/null
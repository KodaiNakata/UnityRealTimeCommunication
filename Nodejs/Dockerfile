# ベースイメージとしてNode.jsのltsを使用
FROM node:lts

# 作業ディレクトリを設定
WORKDIR /opt/unity-nodejs

# package.jsonをコピーして依存関係をインストール
COPY package.json ./
RUN npm install

# コンテナを終了させないためのコマンド
CMD tail -f /dev/null
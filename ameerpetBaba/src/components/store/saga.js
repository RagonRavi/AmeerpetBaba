import app from '../../components';

export default function* saga() {
  yield [
    app.saga(),
  ];
}

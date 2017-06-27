import { AmeerpetBabaPage } from './app.po';

describe('ameerpet-baba App', () => {
  let page: AmeerpetBabaPage;

  beforeEach(() => {
    page = new AmeerpetBabaPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});

import { mGISv3TemplatePage } from './app.po';

describe('mGISv3 App', function() {
  let page: mGISv3TemplatePage;

  beforeEach(() => {
    page = new mGISv3TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

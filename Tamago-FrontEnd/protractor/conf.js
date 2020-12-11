exports.config = {
  seleniumAddress: 'http://localhost:4444/wd/hub',
  directConnect: true,
  specs: [
    'login-spec.js',
    'register-spec.js',
    'animalpicker-spec.js',
    'dashboard-spec.js',
    'gamepage-spec.js',
    'inventory-spec.js',
    'shop-spec.js',
    'sleep-spec.js'
  ], 
  
  capabilities: {
      'browserName': 'chrome', 
  },
  framework: 'jasmine'
};